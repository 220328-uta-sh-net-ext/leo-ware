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


#while [ 1 <= $x ] [ $z <= 1000 ];
#do
read x 
read y 
read z

if [[ $x == $z ]] && [[ $y == $x ]]; then
    echo "EQUILATERAL"
elif [[ $x == $z ]] || [[ $y == $x ]] || [[ $z == $y ]]; then
    echo "ISOSCELES"
    
    else
        echo "SCALENE"
#done
fi