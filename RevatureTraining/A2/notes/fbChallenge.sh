

read -r i 
until [[ $i -le 20 ]]
do ((i%3 && i%5))
i=$(( i++ ))
echo $i
done
until
 if ((i%3 == 0))
 then
echo 'fizz'
 fi
  do
 if ((i%5 == 0))
echo 'buzz'
 then
 if ((i%3 == 0)) && ((i%5 == 0))
echo 'FizzBuzz'
 then
 echo $i
 fi
fi 


done
