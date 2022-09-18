string[] array = { "butter1", "-345678", "cat", "3,14", "Irina", "746", "^-(" };
int size = 3;

void FormingAnArrayFromStrings(string[] arrayIn, int size)
{
    int count = 0;
    int i = 0;
    for (i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= size)
        {
            count++;
        }
    }
    string[] arrayOut = new string[count];
    count = 0;
    for (i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= size)
        {
            arrayOut[count] = arrayIn[i];
            count++;
        }
    }
}
