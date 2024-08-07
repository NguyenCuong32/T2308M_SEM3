import email
import json
from tokenize import group
from pymongo import MongoClient

connetion_string ="mongodb+srv://cuongnx:9OPIaOBkYGIn4Ps0@mongocluster.0sn5a89.mongodb.net/?tls=true&authMechanism=SCRAM-SHA-1"
database_name ="sample_mflix"
name_user ="users"
name_movie ="movies"

client = MongoClient(connetion_string)
db = client[database_name]
collection_user = db[name_user]
collection_movie = db[name_movie]
def demo_match(email):
   match_query ={"$match":{"email":email}}
   pipeline = [match_query]
   results = collection_user.aggregate(pipeline)
   for user in results:
       print(user["name"])
       print(user["email"])
    
   print("Match")
def demo_group(type):
    match_query = {"$match":{"type":type}}
    group_query ={"$group": {  "_id": "$year", "movie_count": { "$sum": 1 }}}
    # count_query ={"_id":"$sum"}
    pipeline = [group_query]
    results = collection_movie.aggregate(pipeline)
    for r in results:
        print(r)
        


def menu():
    print("Demo Aggregation")
    while(True):
        choice = input("Please enter a number:")
        if(choice =="1"):
            email = input("Please an email: ")
            demo_match(email)
        if(choice =="2"):
            type = input("Please enter a type: ")
            demo_group(type)

if __name__ == "__main__":
    menu()