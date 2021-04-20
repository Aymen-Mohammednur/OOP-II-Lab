import os

for i in range(32):

    os.system(f'dotnet new console -n Question{i+1}')
