namespace Desayuno.prepraraciones;

public class asyncZumo
{
    public async Task<string>  exprimirZumo()
    {
            await Task.Delay(200);
            return "Expremir Zumo";
      
    }
}