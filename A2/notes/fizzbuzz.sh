i=1 
until [i <= 20], i++
do (($i % 3)) && (($i % 5))
i=$(( i+1 ))
echo $i
if (($i % 3 == 0))
echo 'fizz'
break
if (($i % 5 == 0))
echo 'buzz'
break
if (($i % 3 == 0)) && (($i % 5 == 0))
echo 'FizzBuzz'
break
else
echo $i
fi
<<comment
then
echo

else
echo

else
echo


fi
comment