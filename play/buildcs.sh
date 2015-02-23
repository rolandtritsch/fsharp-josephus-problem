export name=${1}
mcs ${name}.cs -pkg:dotnet && mono ${name}.exe ${2} ${3} ${4} ${5} ${6} ${7} ${8} ${9}
