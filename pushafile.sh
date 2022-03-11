#!usr/bin/bash

echo $'Lets git that file and push it! \nEnter stop at anytime to exit script... \n'

while [ true ]; do

read -p $'Please enter file name: \n' filename

	if [[ $filename^^ == "STOP" || $filename == "stop" ]]; then

               	break

        elif [[ -z $filename ]]; then

                echo $'Input empty, please input file name... \n'
	else

		git add $filename
	fi

read -p $'Please enter commit message that will be pushed: \n' message


	if [[ $message^^ == "STOP" || $message == "stop" ]]; then

                break

        elif [[ -z $message ]]; then

                echo $'Input empty, please input commit message... \n'

	else

		git commit -m "$message"
	fi

	echo $'Pushing file to origin... \n'


	git push

done

echo "Exiting pushafile... "
