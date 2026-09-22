
using System.Diagnostics;
using Desayuno.prepraraciones;
using Desayuno.prepraraciones.pan;
using Desayuno.prepraraciones.sarten;
using Desayuno.prepraraciones.sarten.baicon;
using Desayuno.prepraraciones.sarten.huevos;

using var cts = new CancellationTokenSource();
using var cts2 = new CancellationTokenSource();


    var cafe = new cafe();
    var sarten = new sarten();
    var beicon = new baicon();
    var huevo = new huevos();
    var tostar = new tostar();
    var untar = new untar();
    var zumo = new zumo();

    var asyncCafe = new asyncCafe();
    var asyncSarten = new asyncSarten();
    var asyncBaicon = new asyncBaicon();
    var asyncHuevos = new asyncHuevos();
    var asyncTostar = new asyncTostar();
    var asyncUntar = new asyncUntar();
    var asyncZumo = new asyncZumo();

    var tokenCafe = new asyncCafeToken();
    var tokenSarten = new asyncSartenToken();
    var tokenBeicon = new asyncBaiconToken();
    var tokenHuevo = new asyncHuevosToken();
    var tokenTostar = new asyncTostarToken();
    var tokenZumo = new asyncZumoToken();
    var tokenUntar = new asyncUntarToken();

    var cronometro = Stopwatch.StartNew();

            cafe.HacerCafe();
            zumo.exprimirZumo();
            sarten.calentarSarten();
            tostar.tostarPan();
            beicon.freirBaicon();
            huevo.freirHuevo();
            untar.untarPan();


    cronometro.Stop();


        Console.WriteLine("Total sincrono "  + cronometro.ElapsedMilliseconds);
        

    cronometro.Reset();
    cronometro.Start();

        var hacerCafe = await  asyncCafe.HacerCafe();
        var exprimirZumo = await asyncZumo.exprimirZumo();

        var calentarSarten = await asyncSarten.calentarSarten();
        var freirBaicon = await asyncBaicon.freirBaicon();
        var freirHuevo = await asyncHuevos.freirHuevo();

        var tostarPan = await asyncTostar.tostarPan();
        var untarPan = await asyncUntar.untarPan();

        Console.WriteLine("Total asincrono mal "  + cronometro.ElapsedMilliseconds);

    cronometro.Stop();



    cronometro.Reset();
    cronometro.Start();


        var tareaCafe =    asyncCafe.HacerCafe();
        var tareaZumo =  asyncZumo.exprimirZumo();
        var tareaPan =  asyncTostar.tostarPan();
        var tareaSarten =  asyncSarten.calentarSarten();
        
        await Task.WhenAll(tareaCafe, tareaZumo, tareaPan, tareaSarten);

        var tareaBaicon =   asyncBaicon.freirBaicon();
        var tareaUntar =   asyncUntar.untarPan();
        
        await Task.WhenAll(tareaBaicon, tareaUntar);

        var huevos = await asyncHuevos.freirHuevo();

    cronometro.Stop();

    Console.WriteLine("Total asincrono bien "  + cronometro.ElapsedMilliseconds);

    cts.CancelAfter(TimeSpan.FromMilliseconds(500));
    


    try
    {
        cronometro.Reset();
        cronometro.Start();
        
        Console.WriteLine("---Cancelacion asincrono mal---");
        var Cafe01 = await tokenCafe.HacerCafe(cts.Token);
        var Zumo01 = await tokenZumo.exprimirZumo(cts.Token);
        var Pan01 = await tokenTostar.tostarPan(cts.Token);
        var Sarten01 = await  tokenSarten.calentarSarten(cts.Token);
        var Baicon01 = await  tokenBeicon.freirBaicon(cts.Token);
        var Untar01 =  await tokenUntar.untarPan(cts.Token);
        var huevos01 = await asyncHuevos.freirHuevo();
             
                
    }
    catch (OperationCanceledException)
    { 
        Console.WriteLine(cronometro.ElapsedMilliseconds + " ya no desayuno");
    }
        cronometro.Stop();
        cts2.CancelAfter(TimeSpan.FromMilliseconds(500));
    try
    {
        Console.WriteLine("---Cancelacion asincrono bien---");
        cronometro.Reset();
        cronometro.Start();
                
            var tareaCafe01 = tokenCafe.HacerCafe(cts2.Token);
            var tareaZumo01 =  tokenZumo.exprimirZumo(cts2.Token);
            var tareaPan01 =  tokenTostar.tostarPan(cts2.Token);
            var tareaSarten01 =  tokenSarten.calentarSarten(cts2.Token);
            
            await Task.WhenAll(tareaCafe01, tareaZumo01, tareaPan01, tareaSarten01);
            
            var tareaBaicon01 =   tokenBeicon.freirBaicon(cts2.Token);
            var tareaUntar01 =   tokenUntar.untarPan(cts2.Token);
                
            await Task.WhenAll(tareaBaicon01, tareaUntar01);

            var huevos01 = await tokenHuevo.freirHuevo(cts2.Token);
            
            Console.WriteLine(cronometro.ElapsedMilliseconds);
            
                
    }
    catch (OperationCanceledException)
    { 
        Console.WriteLine(cronometro.ElapsedMilliseconds + " ya no desayuno");
    }
    cronometro.Stop();

        
            
     
        
