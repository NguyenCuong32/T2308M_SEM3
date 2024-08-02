from pymongo import MongoClient

print("Demo connection to mongodb")

connection_string ="mongodb://root:123456@127.0.0.1:27017/"
client = MongoClient(connection_string)
database_name ="SystemInformationStudent"
collection_name ="User"

db = client[database_name]
collection = db[collection_name]



def addUser(username,fullname):
    print("Add User method")
    user = {"username":username,"fullname":fullname}
    collection.insert_one(user)
    print("Added a user")

def addUsers(users):
    print("Insert many")
    collection.insert_many(users)
    print("Inserted")

def updateUser(username, newfullname):
    # newuser = {"username":username}, {"$set":{"fullname":newfullname}}
    newuser ={"$set":{"fullname":newfullname}}
    conditionuser = {"username":username}
    collection.update_one(conditionuser,newuser,upsert=True)
    # collection.update_one(newuser)
    print("Updated.")

def showAllUser():
    if collection is None:
        print("Can not connnected")
    else:
        print("Connected successfull")
        for user in collection.find():
            print(user["username"])
            print(user["fullname"])

def deleteUser(username):
    if collection is not None:
        user = {"username":username}
        collection.delete_one(user)
    
def menu():
    while(True):
        choice = input("Enter a number:")
        if choice == "1":
            username = input("Username: ")
            fullname = input("Fullname: ")
            addUser(username,fullname)
        if choice == "2":
            username = input("Remove username: ")
            deleteUser(username)
        if choice == "3":
            username = input("Username: ")
            newfullname = input ("Fullname: ")
            updateUser(username,newfullname)
        if choice == "4":
            showAllUser()
        if choice == "5":
            users = []
            for user in range(3):
                username = input("Username: ")
                fullname = input("Fullname: ")
                users.append({"username":username,"fullname":fullname})
            addUsers(users)


if __name__ == "__main__":
    menu()