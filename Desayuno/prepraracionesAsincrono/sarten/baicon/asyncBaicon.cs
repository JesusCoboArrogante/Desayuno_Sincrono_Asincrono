using System.Diagnostics;

namespace Desayuno.prepraraciones.sarten.baicon;

public class asyncBaicon
{
    public async Task<string> freirBaicon()
    {
     
            await Task.Delay(300);
            return "Freir baicon";
        
        
        
    }
}