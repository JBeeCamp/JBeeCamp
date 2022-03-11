#!usr/bin/bash

while [ true ]; do

read -p $'Please enter file name: \n' filename

	if [[ $filename^^ == "STOP" || $filename == "stop" ]]; then
                break

        elif [[ -z $filename ]]; then
                echo "Input empty, please input file name."
	else

		git add $filename
	fi

read -p $'Please enter commit message that will be pushed: \n' message

	if [[ $message^^ == "STOP" || $message == "stop" ]]; then
                break

        elif [[ -z $message ]]; then
                echo "Input empty, please input file name."

	else

		git commit -m "$message"
	fi

echo Pushing file to origin.

git push

done

echo "Exiting pushafile... "
