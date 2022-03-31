

# Single line comment
: '
this is
multi-line
Comment
'
#Shebang/hash bang -> mentions which shell to be used and its location in OS
# $ which bash -> is simply a command that prints which version of bash you are using
#! /usr/bin/bash

# The *echo* command is similar to the *print* command used in JavaScript console
# print Hello world to the terminal when this file is run
echo "Hello World"

# System defined variables
# type a '$' right before the variable. No space in between
# we can use " " after echo command but it is not necessary
echo "My shell version $BASH_VERSION"
echo "My directory is $PWD"
echo My home directory id $HOME

# User defined variables
name=Leo
echo "The name is $name"

# User defined variables, use A-Z, a-z, 0-9 or _
# If you define a variable with a number as the first character in your variable name, it will not be read the variable correctly. 
10USD=10
echo "the value is $10USD"
# vs
1USD=10
echo "the value is $1USD"
# vs
_USD=10
echo "The value is $_USD"

# If you call variables and commands in a line of code encapsulated by single quotations '', the variable will not execute and will print as a string literal
echo 'My home directory ID is $HOME, home boi!'
echo 'The name is $name'

# variables mean objects that vary or are varied. Literally "able" to be "varied"
# constants are variables that should stay constant. They should not be changed.
pi=3.14
readonly pi
# this will lock the value and it cannot be changed or unset
## unset pi # unset is used to remove a value, but with readonly variables it cannot be unset
pi=22.7
echo "The value os pi is $pi"

pi=3.14
# readonly pi
pi=22.7
echo "The value os pi is $pi"

