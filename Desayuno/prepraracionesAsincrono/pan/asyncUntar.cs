namespace Desayuno.prepraraciones.pan;

public class asyncUntar
{
    public async Task<string>  untarPan()
    {
        
            await Task.Delay(100);
            return "Untar pan";
       
        
    }
}