import os

for i in range(11):

    os.system(f'cmd /c dotnet new console -n Question{i+1}')
