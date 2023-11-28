Société TristanAuto = new Société("TristanAuto", 5);
TristanAuto.AddSociétéChilds(new Société("TristanAutoFiliale1", 12));
TristanAuto.AddSociétéChilds(new Société("TristanAutoFiliale2", 4));
TristanAuto.AddSociétéChilds(new Société("TristanAutoFiliale3", 8));
TristanAuto.AddSociétéChilds(new Société("TristanAutoFiliale4", 3));

TristanAuto.childs[2].AddSociétéChilds(new Société("UneAutreFiliale", 5));

Console.WriteLine("Le nombre de véhicule total : " + TristanAuto.GetNbVehicules().ToString());
