using JsonParseList;


var descriptionDetail = Algorithms.DescriptionDetail();

int line = 1;
Console.WriteLine($" Line | Text");
foreach (string item in descriptionDetail)
{
    Console.WriteLine($" {line} | {item}");
    line++;
}