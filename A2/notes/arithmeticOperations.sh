# Arithmetic expansion and evaluation format:
$((expression))
$(( n1+n2 ))
$(( n1/n2 ))
$(( n1-n2 ))

# Add two numbers on fly using the echo command:
echo $(( 10 + 5 ))

# Add two numbers using x and y variable.
#Create a shell program called add.sh using a text editor:
x=5
y=10
ans=$(( x + y ))
echo "$x + $y = $ans"

# Save and close the file. Run it as follows:
chmod +x add.sh
./add.sh


# Create an interactive program using the read command called add1.sh using a text editor:
read -p "Enter two numbers : " x y
ans=$(( x + y ))
echo "$x + $y = $ans"

chmod +x add1.sh
./add1.sh
# Enter two numbers : num num
# num + num = num

<<comment
+	Addition	echo $(( 20 + 5 ))	25
-	Subtraction	echo $(( 20 - 5 ))	15
/	Division	echo $(( 20 / 5 ))	4
*	Multiplication	echo $(( 20 * 5 ))	100
%	Modulus	echo $(( 20 % 3 ))	2

++	post-increment (add variable value by 1)
x=5
echo $(( x++ )) 5
echo $(( x++ )) 6

--	post-decrement (subtract variable value by 1)
x=5
echo $(( x-- ))	4

**	Exponentiation	x=2 y=3
echo $(( x ** y ))	8
comment

# To create an integer variable use the declare command as follows:
declare -i y=10
echo $y

# Create a shell script called intmath.sh
# set x,y and z to an integer data type
declare -i x=10
declare -i y=10
declare -i z=0
z=$(( x + y ))
echo "$x + $y = $z"

# try setting to character 'a'
x=a
z=$(( x + y ))
echo "$x + $y = $z"

#Save and close the file. Run it as follows
chmod +x intmath.sh
./intmath.sh

# Sample outputs
10 + 10 = 20
0 + 10 = 10

# Write a loop that displays only odd natural numbers from 1 to 99
i=0
for ((i=0; i< 99+1; i++))
    do
        if (( i%2 != true))
            
            then
            
            echo $i
        fi
    done
# The output should print all odd numbers from 1 to 99 in the terminal    

# Write a loop to display the natural numbers from 1 to 50
i=1
for ((i=1; i< 50+1; i++))
    do
        if (( i > 50 == false ))
            
            then
            
            echo $i
        fi
    done
# The output should print numbers 1 to 50 in the terminal

# You can create the constants variables using the readonly command or declare command.
# The readonly buitin syntax is as follows:
readonly var
readonly varName=value
# The declare builtin syntax is as follows:
declare -r var
declare -r varName=value


# Create a constant variable called DATA and make its value always the same throughout the shell script i.e. it can't be changed:
readonly DATA=/home/sales/data/feb09.dat
echo $DATA
/home/sales/data/feb09.dat
DATA=/tmp/foo
# Error ... readonly variable
# You cannnot unset (delete) the readonly variable:
unset DATA
# Sample outputs
bash: unset: DATA: cannot unset: readonly variable


# If the variable is not defined, you can stop executing the Bash script with the following syntax:
${varName?Error varName is not defined}
${varName:?Error varName is not defined or is empty}
# This is useful for a sanity checking
# The script will stop executing if the variable is not defined.

# Create a shell script called varcheck.sh:
#!/bin/bash
# varcheck.sh: Variable sanity check with :? 
path=${1:?Error command line argument not passed}

echo "Backup path is $path."
echo "I'm done if \$path is set."

# Run it as follows
chmod +x varcheck.sh
./varcheck.sh /home

<<comment1
# Sample outputs:

Backup path is /home.
I'm done if $path is set.
comment1

# Run the script without any arguments
./varcheck.sh

# Sample outputs
./varcheck.sh: line 3: 1: Error command line argument not passed


((==,>,<,>=,<=,!=)) ||  [-eq,-gt...]
if((x < y)) then do... this elif((x > y)) then do... else
