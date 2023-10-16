string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length) + "\n");

string message1 = "Find what is (inside the parentheses)";
int openingPosition1 = message.IndexOf('(');
int closingPosition1 = message.IndexOf(')');
Console.WriteLine(openingPosition1);
Console.WriteLine(closingPosition1 + "\n");
openingPosition1 += 1;
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message.Substring(openingPosition1, length1) + "\n");

string message2 = "What is the value <span>between the tags</span>?";
int openingPosition2 = message.IndexOf("<span>");
int closingPosition2 = message.IndexOf("</span>");
openingPosition2 += 6;
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message.Substring(openingPosition2, length2));
