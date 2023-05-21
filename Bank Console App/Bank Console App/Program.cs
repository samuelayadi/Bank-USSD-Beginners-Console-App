// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        string Code =Console.ReadLine();
        if(Code == "*860#")
        {
            Console.WriteLine("You are welcome to Silky Bank App, What offer can we render you?");
            Console.WriteLine("1. Pay Bills");
            Console.WriteLine("2. Recharge Airtime");
            Console.WriteLine("3. Make Loan Request");
            Console.WriteLine("4. Transfer Funds");

        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        int Choice1=int.Parse(Console.ReadLine());
        Console.Clear();
        switch (Choice1) {
            case 1:
               Console.WriteLine("Select the Utility Bill You want to pay for");
               Console.WriteLine("1. Electricity Bills");
               Console.WriteLine("2. Cable Tv");
               Console.WriteLine("3. Betting");
               Console.WriteLine("4. JAMB ePin");
               Console.WriteLine("5. Cowry Card");
                 int PayBills = int.Parse(Console.ReadLine());
                 Console.Clear();
                switch (PayBills)
                   {
                        case 1:
                        Console.WriteLine("1. Ikeja Electricity ");
                        Console.WriteLine("2. Ibadan Electricity ");
                        Console.WriteLine("3. Lagos Electricity ");
                        Console.WriteLine("4. Eko Electricity ");
                        Console.WriteLine("5. Port-Harcourt Electricity ");
                        Console.WriteLine("6. Enugu Electricity ");
                        Console.WriteLine("7. Yola Electricity ");
                        Console.WriteLine("8. Edo Electricity ");
                        int ElectChoice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        string ElectPort = "";
                        if (ElectChoice<9 && ElectChoice > 0)
                        {
                            if (ElectChoice == 1) { 
                                ElectPort = "Ikeja Electricity";
                            }else if(ElectChoice == 2)
                            {
                                ElectPort = "Ibadan Electricity";
                            }else if(ElectChoice == 3)
                            {
                                ElectPort = "Lagos Electricity";
                            }else if (ElectChoice == 4)
                            {
                                ElectPort = "Eko Electricity";
                            }
                            else if (ElectChoice == 5)
                            {
                                ElectPort = "Port-Harcourt Electricity";
                            }else if (ElectChoice == 6)
                            {
                                ElectPort = "Enugu Electricity";
                            }
                            else if (ElectChoice == 7)
                            {
                                ElectPort = "Yola Electricity";
                            }
                            else if (ElectChoice == 8)
                            {
                                ElectPort = "Edo Electricity";
                            }
                            Console.WriteLine(ElectPort);
                            Console.WriteLine("Enter Your Choice");
                            Console.WriteLine("1. Postpaid");
                            Console.WriteLine("2. Prepaid");
                            int ElectPaid = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (ElectPaid)
                            {
                                case 1:
                                    Console.WriteLine("Enter Your meter Number");
                                    string MeterNo = Console.ReadLine();
                                    Console.WriteLine("Enter the Amount");
                                    string MeterAmount = Console.ReadLine();
                                    switch (MeterNo)
                                    {
                                        case null:
                                            Console.Clear();
                                            Console.WriteLine("Meter Number is not Provided");
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Your Transfer of "+ MeterAmount + " to meter "+ MeterNo+ " is Successful");
                                            break;
                                    }
                                    switch (MeterAmount)
                                    {
                                        case null:
                                            Console.WriteLine("Amount is not Provided");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    Console.WriteLine("Enter Your meter Number");
                                    string MeterNo1 = Console.ReadLine();
                                    Console.WriteLine("Enter the Amount");
                                    string MeterAmount1 = Console.ReadLine();
                                    Random rand1 = new Random();    
                                    int MeterRand1 = rand1.Next(00000, 99999);
                                    int MeterRand2 = rand1.Next(00000, 99999);
                                    int MeterRand3 = rand1.Next(00000, 99999);
                                    int MeterRand4 = rand1.Next(00000, 99999);

                                    switch (MeterNo1)
                                    {
                                        case null:
                                            Console.Clear();
                                            Console.WriteLine("Meter Number is not Provided");
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Your Transfer of " + MeterAmount1 + " to meter " + MeterNo1 + " is Successful Your Meter Code is "+ MeterRand1+"-"+MeterRand2+"-" +MeterRand3+ "-" + MeterRand4);
                                            break;
                                    }
                                    switch (MeterAmount1)
                                    {
                                        case null:
                                            Console.WriteLine("Amount is not Provided");
                                            break;
                                    }
                                    break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                        case 2:
                        Console.WriteLine("1. DSTV ");
                        Console.WriteLine("2. GOTV ");
                        Console.WriteLine("3. Startimes ");
                        Console.WriteLine("4. Showmax ");
                        Console.WriteLine("5. Box-Office ");
                        int CableTv = int.Parse(Console.ReadLine());
                        Console.Clear();
                        string CableTvChoice = "";
                        switch (CableTv >0 && CableTv<6)
                        { 
                            case true:
                                switch(CableTv)
                                {
                                    case 1:
                                        CableTvChoice = "DSTV";
                                        break;
                                    case 2:
                                        CableTvChoice = "GOTV";
                                        break;
                                    case 3:
                                        CableTvChoice = "StarTimes";
                                        break;
                                    case 4:
                                        CableTvChoice = "Showmax";
                                        break;
                                    case 5:
                                        CableTvChoice = "Box-Office";
                                        break;


                                }
                                Console.WriteLine("Enter your "+ CableTvChoice+ " ID Number");
                                string CableTvID = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Choose Your Suitable Package");    
                                Console.WriteLine("1. Min Package");
                                Console.WriteLine("2. Mid Package");
                                Console.WriteLine("3. Max Package");    
                                int PackageChoice=int.Parse(Console.ReadLine());    
                                Console.Clear();
                                switch (PackageChoice)
                                {
                                    case 1:
                                        Console.WriteLine("Your "+ CableTvChoice + " Min Package subscription to ID No " + CableTvID + " is successful");
                                        break;
                                    case 2:
                                        Console.WriteLine("Your " + CableTvChoice + " Mid Package subscription to ID No " + CableTvID + " is successful");
                                        break;
                                    case 3:
                                        Console.WriteLine("Your " + CableTvChoice + " Max Package subscription to ID No " + CableTvID + " is successful");
                                        break;
                                }
                                break;
                            case false:
                                Console.WriteLine("Invalid Input");
                                break;
                        }
                        break;
                        case 3:
                        Console.WriteLine("Choose your Betting Platform");
                        Console.WriteLine("1. Sportybet");
                        Console.WriteLine("2. Bet 9ja");
                        Console.WriteLine("3. 1x bet");
                        Console.WriteLine("4. Nairabet");
                        Console.WriteLine("5. MSport");
                        Console.WriteLine("6. Bangbet");
                        Console.WriteLine("7. BetKing");
                        Console.WriteLine("8. BetBiga");
                        Console.WriteLine("9. EasyWin");
                        int BetPlatFormChoice =int.Parse(Console.ReadLine());
                        string BetChoice = "";
                        Console.Clear();
                        switch (BetPlatFormChoice>0 && BetPlatFormChoice<10)
                        {
                            case true:
                                switch (BetPlatFormChoice)
                                {
                                    case 1:
                                        BetChoice = "SportyBet";
                                        break;
                                    case 2:
                                        BetChoice = "Bet9ja";
                                        break;
                                    case 3:
                                        BetChoice = "1x bet";
                                        break;
                                    case 4:
                                        BetChoice = "Nairabet";
                                        break;
                                    case 5:
                                        BetChoice = "MSport";
                                        break;
                                    case 6:
                                        BetChoice = "BangBet";
                                        break;
                                    case 7:
                                        BetChoice = "BetKing";
                                        break;
                                    case 8:
                                        BetChoice = "BetBiga";
                                        break;
                                    case 9:
                                        BetChoice = "Easywin";
                                        break;
                                }
                                Console.WriteLine("Provide Your " + BetChoice + " User ID Below");
                                string BetUserID = Console.ReadLine();
                                Console.WriteLine("Provide your Top up Amount");
                                string BetAmount = Console.ReadLine();  
                                Console.Clear();
                                Console.WriteLine("Your Transfer of " + BetAmount + " to the "+ BetChoice+ " account with the User ID "+ BetUserID+" is successful");
                                break;
                            case false:
                                Console.WriteLine("Invalid Input");
                                break;
                        }
                        break;
                        case 4:
                        Console.WriteLine("Note: This Transaction costs #5000 only");
                        Console.WriteLine("Enter 1 to proceed");
                        int EPin = int.Parse(Console.ReadLine());
                        Console.Clear();
                           switch (EPin)
                           {
                                case 1:
                                Console.WriteLine("Enter Your JAMB profile Code");
                                string ProfileCode= Console.ReadLine();
                                Console.WriteLine("Enter Your Full Name");
                                string ProfileName= Console.ReadLine();
                                Random Rand = new Random();
                                int EPinCode = Rand.Next(00000, 99999);
                                int EPinCode1 = Rand.Next(00000, 99999);
                                int EPinCode2 = Rand.Next(00000, 99999);
                                int EPinCode3 = Rand.Next(00000, 99999);
                                Console.Clear();
                                Console.WriteLine("The JAMB Epin for "+ ProfileName+ " with the profile code of "+ ProfileCode + " is"+ " "+ EPinCode+"-"+EPinCode1 + "-" +EPinCode2 + "-" +EPinCode3);
                                break;
                           }
                        break;
                         case 5:
                         Console.WriteLine("Enter your cowry card number below");
                         string CardNo = Console.ReadLine();
                         Console.WriteLine("Enter your Top Up amount");
                         string Price = Console.ReadLine();
                        Console.Clear();
                          switch (Price)
                        {
                            case null:
                                Console.WriteLine("Invalid Amount");
                                break;
                            default:
                                Console.WriteLine("Your Transfer to Card Number"+ CardNo + " with the sum of "+ Price +" is successful");
                                break;
                        }
                        switch (CardNo)
                        {
                            case null:
                            Console.WriteLine("Provide Your Card Number");
                                break;  
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                   }

                break;
            case 2:
               Console.WriteLine("Choose your Network");
               Console.WriteLine("1. Airtel");
               Console.WriteLine("2. Glo");
               Console.WriteLine("3. MTN");
               Console.WriteLine("4. 9 Mobile");
                int NetWorkChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                string Network =  "";
                switch(NetWorkChoice>0 && NetWorkChoice < 5)
                {
                    case true:
                        switch (NetWorkChoice)
                        {
                            case 1:
                                Network = "Airtel";
                                break;
                            case 2:
                                Network = "Glo";
                                break;
                            case 3:
                                Network = "MTN";
                                break;
                            case 4:
                                Network = "9 Mobile";
                                break;
                        }
                        Console.WriteLine("Enter Your "+ Network+ " number");
                        string NetworkNumber = Console.ReadLine();
                        Console.WriteLine("Enter The amount you want to recharge");
                        string NetWorkAmount = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("The Transfer of "+ NetWorkAmount + " to your " + Network+ " line of "+ NetworkNumber + " is successfull");
                        break;
                    case false: 
                        Console.WriteLine("Invalid Input");
                        break;
                }
                break;
            case 3:
                
            Console.WriteLine("Loans not available for now because you've not been using the account for up to 60 days");
                break;
            case 4:
            Console.WriteLine("Please Select the Recipient Bank Transfer");
            Console.WriteLine("1.  FirstBank");
            Console.WriteLine("2.  GT Bank");
            Console.WriteLine("3.  UBA Bank");
            Console.WriteLine("4.  Zenith Bank");
            Console.WriteLine("5.  Wema Bank");
            Console.WriteLine("6.  Silky Bank"); 
            Console.WriteLine("7.  PalmPay");
            Console.WriteLine("8.  OPay");
            Console.WriteLine("9.  Kuda Microfinance Bank");
            Console.WriteLine("10. Sterling Bank");
            Console.WriteLine("11. SmartCash Bank");
            Console.WriteLine("12. Polaris Bank");
            Console.WriteLine("13. FCMB Bank");
            Console.WriteLine("14. Fidelity Bank");
            Console.WriteLine("15. PayAttitude");
            Console.WriteLine("16. MoniePoint Microfinance bank");
            Console.WriteLine("17. Access Bank");
            Console.WriteLine("18. EcoBank");
            Console.WriteLine("19. Heritage Bank");
            Console.WriteLine("20. Globus Bank");
            int BankChoice = int.Parse(Console.ReadLine());
                string BankName = "";
                Console.Clear();
                switch (BankChoice>0 && BankChoice<21)
                {
                    case true:
                        switch (BankChoice)
                        {
                            case 1:
                                BankName = "FirstBank";
                                break;
                            case 2:
                                BankName = "GT Bank";
                                break;
                            case 3:
                                BankName = "UBA Bank";
                                break;
                            case 4:
                                BankName = "Zenith Bank";
                                break;
                            case 5:
                                BankName = "WEMA Bank";
                                break;
                            case 6:
                                BankName = "Silky Bank";
                                break;
                            case 7:
                                BankName = "PalmPay";
                                break;
                            case 8:
                                BankName = "OPay";
                                break;
                            case 9:
                                BankName = "Kuda Microfinance Bank";
                                break;
                            case 10:
                                BankName = "Sterling Bank";
                                break;
                            case 11:
                                BankName = "SmartCash Bank";
                                break;
                            case 12:
                                BankName = "Polaris Bank";
                                break;
                            case 13:
                                BankName = "FCMB Bank";
                                break;
                            case 14:
                                BankName = "Fidelity Bank";
                                break;
                            case 15:
                                BankName = "PayAttitude";
                                break;
                            case 16:
                                BankName = "MoniePoint MicroFinance Bank";
                                break;
                            case 17:
                                BankName = "Access Bank";
                                break;
                            case 18:
                                BankName = "EcoBank";
                                break;
                            case 19:
                                BankName = "Globus Bank";
                                break;
                            case 20:
                                BankName = "Heritage Bank";
                                break;

                        }
                        Console.WriteLine(BankName);
                        Console.WriteLine("Enter the Recipient's Account Number");
                        string BankAccountNumber = Console.ReadLine();
                        Console.WriteLine("Enter the Amount you want to transfer");
                        string TrfAmount = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Your transfer to Recipient Bank "+ BankName + " with the Bank ID of "+ BankAccountNumber+ " is successful");
                        break;
                    case false:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                break;
            default: 
                Console.WriteLine("Invalid Input");
                break;

        }
    }
}
