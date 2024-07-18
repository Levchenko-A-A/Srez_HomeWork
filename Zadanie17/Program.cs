//Напишите программу, которая проверяет, является ли введенное
//пользователем слово панграммой (содержит все буквы алфавита).

string alfavit = "ЙйЦцУуКкЕеНнГгШшЩщЗзХхъФфЫыВвАаПпРрОоЛлДдЖжЭэЯяЧчСсМмИиТтьБбЮю";
Console.Write("Введите строку:");
string str=Console.ReadLine()!;
if (IsPangramm(alfavit, str)) Console.WriteLine("Введеное слово является панграммой");
else Console.WriteLine("Введеное слово не является панграммой");


bool IsPangramm(string strInput,  string strOutput)
{
    int count = 0;
    for (int i = 0; i < strInput.Length; i++)
    {
        for (int j = 0; j < strOutput.Length; j++)
        {
            if (strInput[i] == strOutput[j])
            {
                count++;
                break;
            }
        }
    }
    if(strInput.Length==count) return true;
    else return false;
}