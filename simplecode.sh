#!/usr/bin/bash

declare -A array

array=([key3]=Simple1 [key2]=Simple2 [key1]=Simple3)

for i in "${array[@]}"

do

	echo "$i"

done
