import mysql.connector
import datetime
from alpha_vantage.timeseries import TimeSeries

#ALPHAVANTAGE_API_KEY = "LMLD4P0XA1H59J54"

#connect db
mydb = mysql.connector.connect(host='127.0.0.1', user='snoop', password='snoopin321', database='mydb')
mycursor = mydb.cursor()

def getDates(): # date calculations for extracting relevant data
	
	# this code has multiple skill issues
	# can't get data for weekends, markets closed
	
	date = datetime.datetime.now()
	
	year1 = date.year
	month1 = date.strftime("%m")
	
	day1 = date.strftime("%d")
	day1 = int(day1) - 1
	d1 = (str(year1) + '-' + str(month1) + '-' + str(day1))
	
	day2 = date.strftime("%d")
	day2 = int(day2) - 2
	d2 = (str(year1) + '-' + str(month1) + '-' + str(day2))
	
	day3 = date.strftime("%d")
	day3 = int(day3) - 3
	d3 = (str(year1) + '-' + str(month1) + '-' + str(day3))
	
	day4 = date.strftime("%d")
	day4 = int(day4) - 4
	d4 = (str(year1) + '-' + str(month1) + '-' + str(day4))
	
	dates = (d1, d2, d3, d4)
	
	return dates
	

def getData(symbol): # retrieve and filter financial data
	
	# call API
	ts = TimeSeries(key='LMLD4P0XA1H59J54')
	data, meta_data = ts.get_daily(symbol=symbol, outputsize='compact')
	
	#filter data using date calculations
	dates = getDates()
	close1 = data[dates[0]]
	close2 = data[dates[1]]
	close3 = data[dates[2]]
	close4 = data[dates[3]]
	closes = (close1['4. close'], close2['4. close'], close3['4. close'], close4['4. close'])
	
	return closes
	

# def updateDB(symbol):
	
	
symbol = 'GOOGL' # for testing purposes
closes = getData(symbol)
print(closes)
