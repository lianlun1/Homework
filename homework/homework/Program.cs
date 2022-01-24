string[] List = new string[] { "kjlfsgkj", "1", "ew", "122wwas" };
string[] Result = new string[] {};
int k = 0;

for (int i = 0; i < List.Length; i++)
{
    if (List[i].Length <= 3)
    {
        Result[k] = List[i];
        k++;
    }
}