#!usr/bin/bash

echo $'Lets git that file and push it! \n\nEnter stop at anytime to exit script... \n'

while [ true ]; do

read -p $'Please enter file name: \n\n' filename

	if [[ $filename^^ == "STOP" || $filename == "stop" ]]; then
                break

        elif [[ -z $filename ]]; then
                echo $'Input empty, please input file name... \n\n'
	else

		git add $filename
	fi

read -p $'Please enter commit message that will be pushed: \n\n' message

	if [[ $message^^ == "STOP" || $message == "stop" ]]; then
                break

        elif [[ -z $message ]]; then
                echo $'Input empty, please input file name... \n\n'

	else

		git commit -m "$message"
	fi

echo $'Pushing file to origin... \n\n'

git push

done

echo "Exiting pushafile... "
