Console.Clear();

bool CheckArray(int[]array)
{
    int length = array.Length;
    int index = 0;
    bool check = false;
    while(index <= length/2)
    {
        if(array[index] == array[length-1-index])
        check = true;
        else
        {
        check = false;
        return check;
        }
        index++;
        
    }

return check;
}


int[] polindrom = {1, 4, 5, 9, 1,};

bool CH = CheckArray(polindrom);

Console.WriteLine(CH);
