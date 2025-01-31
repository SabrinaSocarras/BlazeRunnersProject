using System;
using Spectre.Console;
namespace BarbieSecretGarden;
public static class MainMenu
{
    public static void ShowMenu()
    {
        // "Barbie" title in large and pink
        AnsiConsole.Write(
             new FigletText("Welcome  to  Barbie's  Secret  Garden")
                 .Centered()
                 .Color(Color.HotPink)
         );

        var panel = new Panel("This is a fun competition where you have to reach the tulip flower to win the game. You will have to avoid the traps and obstacles that you will find on the way. Each player will have a special ability that will help you to reach the goal. Good luck!")
            .Header("[bold underline white]About[/]")
            .Border(BoxBorder.Double)
            .BorderStyle(new Style(Color.SeaGreen2));
        AnsiConsole.Write(panel);

        Console.WriteLine("");

        // Menu options
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select an option:")
            .AddChoices(new[] {
                "[bold HotPink]New Game[/]", "[bold white]Instructions[/]", "[bold HotPink]Exit[/]"
            }));
        Console.Clear();
        // Handle selected options
        switch (option)
        {
            case "[bold HotPink]New Game[/]":
            AnsiConsole.MarkupLine("Starting the game...");
            break;
            case "[bold white]Instructions[/]":
            AnsiConsole.MarkupLine("Here are the instructions.");
            break;
            case "[bold HotPink]Exit[/]":
            AnsiConsole.MarkupLine("Exiting the game...");
            Console.Clear();
            Environment.Exit(0);
            break;
        }
        }
    }
