import json
import mysql.connector
from alpha_vantage.timeseries import TimeSeries

#ALPHAVANTAGE_API_KEY = "LMLD4P0XA1H59J54"

#connect db
mydb = mysql.connector.connect(host='127.0.0.1', user='snoop', password='snoopin321', database='mydb')
mycursor = mydb.cursor()

def getData(symbol):
	ts = TimeSeries(key='LMLD4P0XA1H59J54')
	data = ts.get_daily(symbol=symbol, outputsize='compact')
	print(data['close'])

#def updateDB(symbol):
	
	
