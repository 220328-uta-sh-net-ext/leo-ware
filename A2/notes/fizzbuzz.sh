i=1 
until [[i <= 20]]
do (($i % 3 && $i % 5))
i=$(( i+1 ))
echo $i
then
 if (($i % 3 == 0))
 then
echo 'fizz'
break
  then
 if (($i % 5 == 0))
echo 'buzz'
break
  then
 if (($i % 3 == 0)) && (($i % 5 == 0))
echo 'FizzBuzz'
break
  then
 else
 fi
fi 
echo $i

done




<<comment
then
echo

else
echo

else
echo


fi
comment