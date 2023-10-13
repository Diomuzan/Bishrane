string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length) + "\n");

string message1 = "What is the value <span>between the tags</span>?";
int openingPosition1 = message1.IndexOf("<span>");
int closingPosition1 = message1.IndexOf("</span>");
openingPosition += 6;
int length1 = closingPosition1 - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length1));