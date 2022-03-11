#!usr/bin/bash

echo $'Lets Remove That File! \n\nEnter stop at anytime to exit script... \n'

while [ true ]; do

        read  -p $'Please enter file to be removed: \n\n' input

	if [[ ${input^^} == "STOP" || $input == "stop" ]]; then
                break
        elif [[ -z $input ]]; then
                echo $'Input empty, please try again. \n\n'
        fi

	rm $input

	echo $'Initializing commit and push for remote deletion... \n\n'

	git commit -a -m $'File deleted! \n\n'

	git push

	echo $'Change has been pushed! \n'
done
