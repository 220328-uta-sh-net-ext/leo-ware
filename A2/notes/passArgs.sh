# echo $BASH

# "echo" is similar to "print"
# "$+variableName" is the argument that is passed through to the bash sans the "echo" command

#****************************************************************************************

#             PASSING ARGUMENTS DIRECTLY INSIDE THE TERMINAL

# Print an unset (unnamed) variable; then prompt the user to input a name for the variable in the terminal
# echo *variable name here* ' > echo *variable name here*'
echo $1 $2 $3 ' > echo $1 $2 $3'

# inside the terminal, type *./fileName.sh user input here*
# for example: *./passArgs.sh Bob Tom Jerry*
# The terminal will print "Bob Tom Jerry > echo $! $2 $3"
# This line of code is allowing you to pass arguments into the variables using the bash terminal.
# It turns those inputs into an array index
# We see what would be index [1], [2] and [3], but what is the value of index [0]?
echo $0 $1 $2 $3 ' > echo $1 $2 $3'
# *./passArgs.sh* becomes the value of index [0]

# However, if you make the arguments = to the variables being called only the user inputs will be printed in the bash terminal
# Here, we have turned the variable into an array
args=("$@")

echo ${args[0]} ${args[1]} ${args[2]} ${args[3]}
echo ${args[0]} ${args[1]} ${args[2]}
# Now the file name does not show up in the place of index [0]."Bob" is now the value of index [0]
# To prove this I deleted '${args[3]}' and nothing changed from the previous line

# Let's call the array all at once using the variable we assigned to the array
echo $@

# Now we will try to return the number of items that have been inputted inside the array
echo $# #this didn't work... :(
# Nvm XD It didn't work because I had to save the changes to the file to run in the bash terminal as intended...


# Just for giggles I tested out what would happen if I deleted any of the commands inside of the string.
<<comment1 
echo $0 $1 $2 $3 ' echo $1 $2 $3'
echo $0 $1 $2 $3 ' >  $1 $2 $3'
echo $0 $1 $2 $3 ' $1 $2 $3'
comment1

