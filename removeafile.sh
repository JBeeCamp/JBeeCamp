#!usr/bin/bash

echo $'Lets Remove That File! Enter stop at anytime to quit out! \n'

while [ true ]; do

        read  -p $'Please enter file to be removed: \n' input

	if [[ ${input^^} == "STOP" || $input == "stop" ]]; then
                break
        elif [[ -z $input ]]; then
                echo "Input empty, please try again."
        fi

	rm $input

	echo $'Initializing commit and push for remote deletion... \n'

	git commit -a -m $'File deleted! \n'

	git push

	echo $'Change has been pushed! \n'
done
