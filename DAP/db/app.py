import mysql.connector


def connect_to_db():
    return mysql.connector.connect(
        host="localhost",
        user="root",
        password="1234@Abc",   
        database="school_db" 
    )

