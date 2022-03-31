#!-/user/bin/bash

echo "Enter your name: "
read name # take the input from user and save its value in the variable mentioned after
echo "Hello $name"

# Use ctrl+k+c to comment out the selection
# Use ctrl+k+u to uncomment the selection
echo "Enter your name: "
read name # take the input from user and save its value in the variable mentioned after
echo "Hello $name"

echo "enter your names: "
read name1 name2 name3
echo "Hello $name1 $name2 $name3"
echo "Hello $name3"

# Arrays are multi collection values olaced one after another (indexed)
echo "Enter names: "
# use the -a "flag" or command to extract the contents of the variable as an array
read -a names
echo "The names are ${names[0]}"
echo "The names are ${names[0]}, ${names[1]}, ${names[2]}"
# You may also print inputs using a default global system defined variable
echo "Hello. Put some text and see results: "
read
echo "results: $REPLY" # this is a global system defined variable you can use to print the user input


read -p 'Username: ' username  # -p is the "flag" or command for prompt
echo "username is $username"
read -sp 'Password: ' password  # -sp is the "flag" or command for "silent" or secure prompt
echo "password is $password"

# Another way to write this:
read -p 'Username: ' username
read -sp 'Password: ' password
echo "username is $username"
echo "password is $password"
# This allows the terminal to print the user inputs exclusively
# And it just looks more legible in the terminal


