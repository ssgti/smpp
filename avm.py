import mysql.connector
import datetime
from alpha_vantage.timeseries import TimeSeries

#ALPHAVANTAGE_API_KEY = "LMLD4P0XA1H59J54"

#connect db
mydb = mysql.connector.connect(host='127.0.0.1', user='snoop', password='snoopin321', database='mydb')
mycursor = mydb.cursor()

def getData(symbol): # retrieve and filter financial data
	# call API
	ts = TimeSeries(key='LMLD4P0XA1H59J54')
	data, meta_data = ts.get_daily(symbol=symbol, outputsize='compact')
	
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



# def updateDB(symbol):
	
	
symbol = 'GOOGL' # for testing purposes
closes = getData(symbol)
print(closes)
