import mysql.connector
import datetime
from alpha_vantage.timeseries import TimeSeries

#ALPHAVANTAGE_API_KEY = "LMLD4P0XA1H59J54"

#connect db
mydb = mysql.connector.connect(host='127.0.0.1', user='snoop', password='snoopin321', database='mydb')
mycursor = mydb.cursor()

def getSymbols():
	mycursor.execute('select symbol from Financial')
	symbols = mycursor.fetchall()
	return symbols

def getData(s): # retrieve and filter financial data
	# call API
	ts = TimeSeries(key='LMLD4P0XA1H59J54')
	data, meta_data = ts.get_daily(symbol=s, outputsize='compact')
	
	# filter data using date calculations
	dates = setDateFormat()
	close1 = data[dates[0]]
	close2 = data[dates[1]]
	close3 = data[dates[2]]
	close4 = data[dates[3]]
	closes = (close1['4. close'], close2['4. close'], close3['4. close'], close4['4. close'])
	return closes

def getMarketDays(s, end, excluded=(6, 7)): # get days when market is open (weekdays)
    days = []
    while s.date() <= end.date():
        if s.isoweekday() not in excluded:
            days.append(s)
        s += datetime.timedelta(days = 1)
    return days

def setDateFormat(): # put dates into correct format for filtering API calls
	today = datetime.datetime.now();
	y = int(today.year)
	m = int(today.month)
	d = int(today.day)

	days = getMarketDays(datetime.datetime(y, m, (d - 6)), datetime.datetime(y, m, d)) # get dates for relevant periods
	dates = []
	for x in range(len(days)):
		year = days[x].year
		month = days[x].strftime("%m")
		day = days[x].strftime("%d")
		dates.append(str(year) + '-' + str(month) + '-' + str(day)) # YYYY-MM-DD format
	return dates

def extractData(data): # remove brackets, apostrophes and commas from data
	data = data.replace('(\'', '')
	data = data.replace('\',)', '')
	return data
	
def updateDB(closes, symbol):
	close1 = extractData(str(closes[0]))
	close2 = extractData(str(closes[1]))
	close3 = extractData(str(closes[2]))
	close4 = extractData(str(closes[3]))
	sql = 'update Financial set P1 = (%s), P2 = (%s), P3 = (%s), P4 = (%s) where symbol = (%s)'
	values = (close1, close2, close3, close4, symbol)
	mycursor.execute(sql, values)
	mydb.commit()
	#mycursor.execute('update Financial set P1 =', closes[0], ', P2 =', closes[1], 'P3 =', closes[2], 'P4 =', closes[3], 'where symbol =', symbol)

# main
# symbol = 'GOOGL' # for testing purposes
symbols = getSymbols()
for s in range(len(symbols)):
	symbol = extractData(str(symbols[s]))
	closes = getData(symbol)
	updateDB(closes, symbol)
