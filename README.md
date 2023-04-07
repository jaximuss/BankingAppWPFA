<?xml version="1.0"?>

<doc>

<assembly>

<name>BankingLibrary</name>

</assembly>

<members>

<member name="P:BankingLibrary.GlobalConfig.connection">

<summary>

allows other parts of the application to access connection property to have access to the connection type

</summary>

</member>

<member name="M:BankingLibrary.GlobalConfig.InitializeConnections(System.String)">

<summary>

this makes the application alot flexible by allowing the user to choose the type of connection they want to use either textfile or sql

</summary>

<param name="connectiontype"></param>

</member>

<member name="M:BankingLibrary.IDataConnection.CreateUser(BankingLibrary.UserModel)">

<summary>

method is used to create a new user and returns a UserModel object containing the details of the newly created user.

</summary>

<param name="model"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.IDataConnection.Login(System.String,System.String)">

<summary>

method takes in two parameters username and password and returns a UserModel object after validating the user's credentials.

</summary>

<param name="username"></param>

<param name="password"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.IDataConnection.CheckBalance(BankingLibrary.UserModel)">

<summary>

method takes a UserModel object as a parameter and returns the account balance of the user as an integer.

</summary>

<param name="user"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.IDataConnection.Deposit(BankingLibrary.UserModel,System.Int32)">

<summary>

method takes a UserModel object and an integer amount as parameters and deposits the specified amount into the user's account.

It also returns the updated account balance as an integer

</summary>

<param name="user"></param>

<param name="amount"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.IDataConnection.Transfer(BankingLibrary.UserModel,System.Int32)">

<summary>

method takes a UserModel object and an integer amount as parameters and transfers the specified amount from the user's account to another account.

It also returns the updated account balance as an integer

</summary>

<param name="user"></param>

<param name="amount"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.TextConnectorProcessor.FullFilePath(System.String)">

<summary>

takes the fullfile path from the app settings and returns the file name

</summary>

<param name="fileName"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.TextConnectorProcessor.LoadFile(System.String)">

<summary>

checks the file to see if it exists and returns a list of strings

</summary>

<param name="file"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.TextConnectorProcessor.ConvertToUserModel(System.Collections.Generic.List{System.String})">

<summary>

reads the file and converts the data to a list of usermodel

</summary>

<param name="lines"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.TextConnectorProcessor.SaveToUserFile(System.Collections.Generic.List{BankingLibrary.UserModel},System.String)">

<summary>

takes the list of usermodel and saves it to the file whilst arranging the data in the correct format

</summary>

<param name="models"></param>

<param name="fileName"></param>

</member>

<member name="T:BankingLibrary.TextFileConnector">

<summary>

all methods and logic to the textfile

</summary>

</member>

<member name="F:BankingLibrary.TextFileConnector.UserFile">

<summary>

the name of the textfile

</summary>

</member>

<member name="M:BankingLibrary.TextFileConnector.CreateUser(BankingLibrary.UserModel)">

<summary>

creates the model gives the user an ID and money

</summary>

<param name="user"></param>

<returns></returns>

</member>

<member name="M:BankingLibrary.TextFileConnector.Deposit(BankingLibrary.UserModel,System.Int32)">

<summary>

adds money to the current account

</summary>

<param name="user"></param>

<param name="amount"></param>

<returns></returns>

<exception cref="T:System.Exception"></exception>

</member>

<member name="M:BankingLibrary.TextFileConnector.Transfer(BankingLibrary.UserModel,System.Int32)">

<summary>

just removes money from the current account

</summary>

<param name="user"></param>

<param name="amount"></param>

<returns></returns>

<exception cref="T:System.Exception"></exception>

</member>

<member name="P:BankingLibrary.UserModel.Id">

<summary>

id of the user

</summary>

</member>

<member name="P:BankingLibrary.UserModel.FirstName">

<summary>

firstname of the user

</summary>

</member>

<member name="P:BankingLibrary.UserModel.LastName">

<summary>

last name of the user

</summary>

</member>

<member name="P:BankingLibrary.UserModel.EmailAddress">

<summary>

email address of the user

</summary>

</member>

<member name="P:BankingLibrary.UserModel.Password">

<summary>

password of the user

</summary>

</member>

<member name="P:BankingLibrary.UserModel.UserName">

<summary>

username of the user

</summary>

</member>

<member name="P:BankingLibrary.UserModel.Money">

<summary>

money of the user

</summary>

</member>

<member name="M:BankingLibrary.UserModel.#ctor">

<summary>

empty ctor no parameter

</summary>

</member>

<member name="M:BankingLibrary.UserModel.#ctor(System.String,System.String,System.String,System.String,System.String)">

<summary>

set values of each property

</summary>

<param name="firstName"></param>

<param name="lastName"></param>

<param name="emailAddress"></param>

<param name="password"></param>

<param name="username"></param>

</member>

</members>

</doc>
