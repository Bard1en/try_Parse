int resultat;
if(!TryParse(Console.ReadLine(),out resultat))
    Console.WriteLine("skriv in en siffra");

static bool TryParse(string s, out int result){
    
    try{
        result = int.Parse(s);
        return true;
    }
    catch{
        result = 0;
        return false;
    }
    
    
}
