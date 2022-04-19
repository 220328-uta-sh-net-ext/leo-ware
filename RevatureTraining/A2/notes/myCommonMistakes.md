# Loops are soooo confusing

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
# ***********************************************************************
# Algebraic Expressions

# The constraints are already set so you don't need to set them
# The given constraints: -100<=x, y<=100, y != 0
# The specified input format (terminal user input): "Two lines containing one integer each ( and , respectively)."
# The specified output format: "Four lines containing the sum (), difference (), product (), and quotient (), respectively. (While computing the quotient, print only the integer part.)"

# --------------------------------------------------------------
# Here are some things I tried while finding the solution:

# for (( expr1 ; expr2 ; expr3 )) ; do commands ; done
# for (( -100<=x y<=100 y != 0 ))
# do
# done
# for [[ -100<=x, y<=100, y != 0 ]]
 #   do
  #  ((x+y = $sum ))
# echo $sum
# yeah... None of this worked :(
# -----------------------------------------------------------------

# Note to self:
# This is NOT a loop so don't use looping constructs. Thank you. ;) <3

    sum=$((x+y))
        echo $sum
        
    difference=$((x-y))
        echo $difference
        
            
    product=$((x*y))
        echo $product
            
               
    quotient=$((x/y))
        echo $quotient

# ********************************************************************

#                This one IS a freakin' loop


# So, guys and gals and people in general. I really screwed the pooch on this one.
# Took me forever to figure out that:
# 1. I was typeing a "-" in front of the "x" because the was they listed off the expected output and input formats was marked by a "-" so, natuarally, I thought it was NEGATIVE "X". Smdh......

# ***Here are some of the mistakes I made below. Enjoy***

# if less=$[ -x -lt y]; then/
# echo "-X is less than Y"
# fi
# if greater=$[ -x -gt y]; then
# echo "-X is greater than Y"
# fi

# if equal=$[ -x -eq y]; then  
 # echo "-X is equal to Y"
# fi
 
# if((x < y)) then do... this elif((x > y)) then do... else

# if less=$(( -x<y ))

# then echo "-X is less than Y"

# elif greater=$(( -x>y ))
    
# then echo "-X is greater than Y"

# equal=$(( -x==y ))
    
# else echo "-X is equal to Y"

# fi

# And then I finally yanked my head out of... a really dark place.... and I realized that not only had I been putting the "-" inside of the perameters as arguments, I had been also putting them into THE STRING! Hhhhh..... So I removed them and found the correct construct order thanks to, Jeramiah. Good lookin' out, buddy.

read x
read y


if [ $x -lt $y ]
then echo "X is less than Y"
elif [ $x -gt $y ]
then echo "X is greater than Y"
else echo "X is equal to Y"
fi

# this loop will output the correct string :) Good Day.


# while [ 1 <= $x ] [ $z <= 1000 ];
# do
read x 
read y 
read z

if [[ $x == $z ]] && [[ $y == $x ]]; then
    echo "EQUILATERAL"
elif [[ $x == $z ]] || [[ $y == $x ]] || [[ $z == $y ]]; then
    echo "ISOSCELES"
    
    else
        echo "SCALENE"
# done
fi

# ---------------------------------------------------------------------

#                    RANDOM SEQUENCE LOOP TWO WAYS

i in $seq[ 1..99..2 ] do echo $i > folderName

for i in $(seq 1..2..99)
do
  echo $i
done

# The above methods are from my fellow peers.
# My code, however, is below. Ummm... I tried XD
# This is not the same 
#i=1
#sum=0
#while [[ $i <= n && n <= 500
#do read num fmt
#echo sum / n bc -1
#seq    average
#Output Format
#Display the average of the N integers, rounded off to three decimal places.
#Input Constraints
#1<= N <=500
#-10000 <= x <= 10000
 #(x refers to elements of the list of integers for which the average is to be computed
 #The '4' in the first line indicates that there are four integers whose average is to be #computed.

#The average = (1 + 2 + 9 + 8)/4 = 20/4 = 5.000 (correct to three decimal places).

#Please include the zeroes even if they are redundant (e.g. 0.000 instead of 0).
