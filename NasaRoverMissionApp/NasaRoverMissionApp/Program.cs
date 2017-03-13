using NasaRoverMissionApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp
{
    public class Program
    {
        
        static int roverXCoordinate = 0;
        static int roverYCoordinate = 0;
        static string roverAlignment = String.Empty;
        static char myRoverFistMoveCommand;
        static char myRoverSecondMoveCommand;
        static string roverFinalPosition = String.Empty;
        static void Main(string[] args)
        {
            RoverForwardMovementServices myRoverForwardMovement = new RoverForwardMovementServices();
            RoverBackwardMovementServices myRoverBackwardMovement = new RoverBackwardMovementServices();
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            Console.Beep();
            Console.WriteLine("=========Welcome to Nasa Rover Mission========");
            Console.WriteLine("Please provide rover x-coordinate :");
            roverXCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Please provide rover y-coordinate :");
            roverYCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Please provide rover alignment :");
            roverAlignment = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Now please provide the rover move command below");
            Console.WriteLine("Please provide first move command");
            myRoverFistMoveCommand = Convert.ToChar(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Please provide second move command");
            myRoverSecondMoveCommand = Convert.ToChar(Console.ReadLine());
            Console.Beep();
            //Console.WriteLine("Please provide third move command");
            //char myRoverThirdMoveCommand = Convert.ToChar(Console.ReadLine());
            //Console.Beep();

            if (roverAlignment == "N" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand=='F')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'R')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "E";
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);

            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'F')
            {
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'R')
            {
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "S";
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'F')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'R')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "W";
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'F')
            {
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'R')
            {
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "N";
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'B')
            {
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'R')
            {
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'B')
            {
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'R')
            {
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "S";
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'B')
            {
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'R')
            {
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "W";
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'L')
            {
                //roverAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsL(myRoverFistMoveCommand);
                //roverAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsL(myRoverSecondMoveCommand);

                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            
            
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'L')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "W";
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'L')
            {
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "W";
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }

            if (roverAlignment == "E" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'L')
            {
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "N";
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'L')
            {
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "N";
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'L')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "E";
                roverXCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'L')
            {
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "E";
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'F' && myRoverSecondMoveCommand == 'L')
            {
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'F')
            {
                roverAlignment = "S";
                roverYCoordinate = myRoverForwardMovement.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'B' && myRoverSecondMoveCommand == 'L')
            {
                roverXCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'B')
            {
                roverAlignment = "S";
                roverYCoordinate = myRoverBackwardMovement.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'L' && myRoverSecondMoveCommand == 'R')
            {
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "N" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "N";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "E" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "E";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "S" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "S";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }
            if (roverAlignment == "W" && myRoverFistMoveCommand == 'R' && myRoverSecondMoveCommand == 'L')
            {
                roverAlignment = "W";
                roverFinalPosition = roverXCoordinate.ToString() + roverYCoordinate.ToString() + roverAlignment;
                Console.WriteLine("Your rover final position is :" + roverFinalPosition);
            }


            Console.ReadLine();
        }
    }
}
