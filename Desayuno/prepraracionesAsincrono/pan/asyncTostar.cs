namespace Desayuno.prepraraciones.pan;

public class asyncTostar
{
    public async Task<string> tostarPan()
    {
            await Task.Delay(200);
            return "Pan tostado";
        
         
    }
}