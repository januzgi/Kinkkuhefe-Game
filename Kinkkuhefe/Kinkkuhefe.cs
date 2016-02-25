﻿using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

public class Kinkkuhefe : PhysicsGame
{
	// TAUSTAKUVAT
	Image taustakuvaalkuValikko = LoadImage("aloituskuva"); 	// Ladataan keittiöstä kuva alkuvalikon taustaksi.
	Image keittokohtaus = LoadImage("keittokohtaus"); 			// Ladataan todellisen toiminnan aikainen näkymä.

	// ALKUVALIKON KOHDAT LISTA
	List<Label> valikonKohdat;

	// OBJEKTIT
	PhysicsObject kinkku;
	PhysicsObject elamansuola;
	PhysicsObject hksininen;
	PhysicsObject jackdaniels;
	PhysicsObject kebabkastike;
	PhysicsObject lanttu;
	PhysicsObject kossu;
	PhysicsObject mandariini;
	PhysicsObject marsipaani;
	PhysicsObject rakuuna;
	PhysicsObject msmjauhe;
	PhysicsObject mustaherukka;
	PhysicsObject mustakitaturska;
	PhysicsObject mustapippuri;
	PhysicsObject sukkahousut;
	PhysicsObject tilli;

	/*
	// MITAT AINEKSIEN LAITTOON
	Image ruiskumitta = LoadImage("ruiskumitta"); 				// Lisätään ruiskumitta
	Image loylykauha = LoadImage("loylykauha"); 				// Lisätään löylykauha
	Image mitta1dl = LoadImage("mitta1dl"); 					// Lisätään desimitan
	Image mittaruokalusikka = LoadImage("mittaruokalusikka");	// Lisätään ruokalusikka
	Image mittateelusikka = LoadImage("mittateelusikka"); 		// Lisätään teelusikka 
	Image soppakauha = LoadImage("soppakauha"); 				// Lisätään soppakauha
	*/

	// LISÄÄ SOKERISIA JUTKUTUSHÄRPÄKKEITÄ
	/*
	Image niittivyo = LoadImage("niittivyo"); 					// Lisätään niittivyö objekti 
	Image pelargonia = LoadImage("pelargonia"); 				// Lisätään pelargonian objekti 
	Image radio = LoadImage("radio"); 							// Lisätään radion objekti 
	Image xboxohjain = LoadImage("xboxohjain"); 				// Lisätään xboxohjain
	Image saunavihta = LoadImage("saunavihta"); 				// Lisätään saunavihta
	*/

	public override void Begin ()
	{

		MultiSelectWindow alkuValikko = new MultiSelectWindow("Oletko kova paistamaan kinkkua?", "OTETAAN!", "HALL OF KINKKUHEFE", "Syön mieluummin ananaspizzaa.");
		Add(alkuValikko);
		alkuValikko.DefaultCancel = 3;							// Peruutusnäppäimellä pelistä pihalle eli ESC poistuu pelistä kuten "Syön mieluummin ananaspizzaa"
		Level.Background.Image = keittokohtaus; 				// Sitten tämä kun aletaan kunnolla kokkaamaan!
		alkuValikko.Color = Color.Transparent;					// Alkuvalikon tekstistä läpinäkyvä.

		IsFullScreen = true; 									// Peli asetetaan kokonäytölle.			
		Level.CreateVerticalBorders ();							// Pelialueelle pystysuuntaiset reunat.

		Mouse.IsCursorVisible = true; 							// Hiiri näkyviin.

		// MAUSTEET / AINEKSET OBJEKTEIKSI
		// THÖ KINKKU
		kinkku = PhysicsObject.CreateStaticObject(Level.Width * 0.25, Level.Height * 0.15);
		kinkku.Image = LoadImage("kinkku");							// Lisätään kinkku
		kinkku.X = -200;
		kinkku.Y = -100;
		Add (kinkku);

		elamansuola = new PhysicsObject (Level.Width * 0.1, Level.Height * 0.2, Shape.Circle);
		elamansuola.Image = LoadImage("elamansuola"); 				// Lisätään suolapurkki
		elamansuola.X = 100;
		elamansuola.Y = 100;
		elamansuola.Tag = "aines";
		Add (elamansuola);

		hksininen = new PhysicsObject (Level.Width * 0.3, Level.Height * 0.1);
		hksininen.Image = LoadImage("hksininen"); 					// Lisätään HK:n sininen eli makkara
		hksininen.X = 150;
		hksininen.Y = 100;
		hksininen.Tag = "aines";
		Add (hksininen);


		jackdaniels = new PhysicsObject (Level.Width * 0.1, Level.Height * 0.3);
		jackdaniels.Image = LoadImage("jackdaniels"); 				// Lisätään Jack Daniels viskipullo
		jackdaniels.X = 200;
		jackdaniels.Y = 100;
		jackdaniels.Tag = "aines";
		Add (jackdaniels);

		kebabkastike = new PhysicsObject (Level.Width * 0.1, Level.Height * 0.3);
		kebabkastike.Image = LoadImage("kebabkastike"); 			// Lisätään kebabkastikepurkit 
		kebabkastike.X = 300;
		kebabkastike.Y = 100;
		kebabkastike.Tag = "aines";
		Add (kebabkastike);

		lanttu = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		lanttu.Image = LoadImage("lanttu"); 						// Lisätään kolmen lanttua
		lanttu.X = 400;
		lanttu.Y = 100;
		lanttu.Tag = "aines";
		Add (lanttu);

		kossu = new PhysicsObject (Level.Width * 0.1, Level.Height * 0.3);
		kossu.Image = LoadImage("kossu"); 							// Lisätään Koskenkorva viinapullo
		kossu.X = 500;
		kossu.Y = 100;
		kossu.Tag = "aines";
		Add (kossu);

		mandariini = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		mandariini.Image = LoadImage("mandariini"); 				// Lisätään mandariini
		mandariini.X = 600;
		mandariini.Y = 100;
		mandariini.Tag = "aines";
		Add (mandariini);

		marsipaani = new PhysicsObject (Level.Width * 0.4, Level.Height * 0.2);
		marsipaani.Image = LoadImage("marsipaani"); 				// Lisätään marsipaani
		marsipaani.X = 700;
		marsipaani.Y = 100;
		marsipaani.Tag = "aines";
		Add (marsipaani);

		rakuuna = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		rakuuna.Image = LoadImage("rakuuna");						// Lisätään rakuuna maustepurkki
		rakuuna.X = -100;
		rakuuna.Y = 100;
		rakuuna.Tag = "aines";
		Add (rakuuna);

		msmjauhe = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		msmjauhe.Image = LoadImage("msmjauhe"); 					// Lisätään MSM -jauhe kippo 
		msmjauhe.X = -200;
		msmjauhe.Y = 100;
		msmjauhe.Tag = "aines";
		Add (msmjauhe);

		mustaherukka = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		mustaherukka.Image = LoadImage("mustaherukka"); 			// Lisätään mustaherukat 
		mustaherukka.X = -300;
		mustaherukka.Y = 100;
		mustaherukka.Tag = "aines";
		Add (mustaherukka);

		mustakitaturska = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		mustakitaturska.Image = LoadImage("mustakitaturska"); 		// Lisätään mustakitaturskan
		mustakitaturska.X = -400;
		mustakitaturska.Y = 100;
		mustakitaturska.Tag = "aines";
		Add (mustakitaturska);

		mustapippuri = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		mustapippuri.Image = LoadImage("mustapippuri"); 			// Lisätään mustapippurit
		mustapippuri.X = -500;
		mustapippuri.Y = 100;
		mustapippuri.Tag = "aines";
		Add (mustapippuri);

		sukkahousut = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		sukkahousut.Image = LoadImage("sukkahousut"); 				// Lisätään sukkahousut
		sukkahousut.X = -600;
		sukkahousut.Y = 100;
		sukkahousut.Tag = "aines";
		Add (sukkahousut);

		tilli = new PhysicsObject (Level.Width * 0.2, Level.Height * 0.2);
		tilli.Image = LoadImage("tilli"); 							// Lisätään tilli
		tilli.X = -700;
		tilli.Y = 100;
		tilli.Tag = "aines";
		Add (tilli);

		/*
		// OHJEKENTTÄ PELAAJALLE
		Label tekstikentta = new Label(300, 50, "ALAHAN KOKATA POIKA!");
		tekstikentta.X = Screen.Right - 250;
		tekstikentta.Y = Screen.Top - 50;
		tekstikentta.TextColor = Color.DarkGray;
		tekstikentta.BorderColor = Color.Black;
		Add(tekstikentta);
		*/


		// HIIREN KÄYTTÖ
		// OBJEKTIEN LIIKUTTELUUN & TUTKIMISEEN
		Mouse.Listen (MouseButton.Left, ButtonState.Down, KuunteleLiiketta, "Lisää aineksia kinkkuun mausteeksi.");

		// PELIN LOPETTAMINEN
		PhoneBackButton.Listen (ConfirmExit, "Lopeta peli");
		Keyboard.Listen (Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
	}

	// LUODAAN ALKUVALIKKO 
	void alkuValikko()
	{
		ClearAll (); 											// Tyhjennetään kenttä kaikista peliolioista
		valikonKohdat = new List<Label> (); 					// Alustetaan lista, johon valikon kohdat tulevat
		Level.Background.Image = taustakuvaalkuValikko; 		// Ladataan keittiöstä kuva pelin aloitusruuduksi

		Label kohta1 = new Label ("Aloita uusi peli");  		// Luodaan uusi Label-olio, joka toimii uuden pelin aloituskohtana
		kohta1.Position = new Vector (0, 40);  					// Asetetaan valikon ensimmäinen kohta hieman kentän keskikohdan yläpuolelle
		valikonKohdat.Add (kohta1);  							// Lisätään luotu valikon kohta listaan jossa kohtia säilytetään

		// Lisätään kaikki luodut kohdat peliin foreach-silmukalla
		foreach (Label valikonKohta in valikonKohdat) 
		{
			Add (valikonKohta);
		}
	}

	// HIIREN KUUNTELU ELI MITÄ TAPAHTUU KUN VASEN HIIRI ON PAINETTU POHJAAN
	void KuunteleLiiketta(AnalogState hiirenTila)
	{   
		
		MessageDisplay.Clear();
		int k = 1;
		while(k == 1)
		{
			if (Mouse.IsCursorOn (Level.Background)) 
			{
				MessageDisplay.Add( "Ota ny jotain!" );
				MessageDisplay.MaxMessageCount = 0;
				k++;
			}

			if (Mouse.IsCursorOn(elamansuola)) 
			{
				elamansuola.X = Mouse.PositionOnWorld.X;
				elamansuola.Y = Mouse.PositionOnWorld.Y;

				MessageDisplay.Add( "Käytä ensi kerralla Himalajan suolaa" );
				MessageDisplay.MaxMessageCount = 0;
				k++;
			}
				
			else if (Mouse.IsCursorOn(hksininen)) 
			{
				hksininen.X = Mouse.PositionOnWorld.X;
				hksininen.Y = Mouse.PositionOnWorld.Y;

				MessageDisplay.Add( "Vähä kyrsää... Brus suomalaista!" );
				MessageDisplay.MaxMessageCount = 0;
				k++;
			}

			else if (Mouse.IsCursorOn(jackdaniels)) 
			{
				jackdaniels.X = Mouse.PositionOnWorld.X;
				jackdaniels.Y = Mouse.PositionOnWorld.Y;

				MessageDisplay.Add( "Sullahan on ihan kehittynyt maku." );
				MessageDisplay.MaxMessageCount = 0;
				k++;
			}

			else if (Mouse.IsCursorOn(lanttu)) 
			{
				lanttu.X = Mouse.PositionOnWorld.X;
				lanttu.Y = Mouse.PositionOnWorld.Y;

				MessageDisplay.Add( "Meidän kunnioitettu puheenjohtaja." );
				MessageDisplay.MaxMessageCount = 0;
				k++;
			} 

			else if (Mouse.IsCursorOn(kossu)) 
			{
				kossu.X = Mouse.PositionOnWorld.X;
				kossu.Y = Mouse.PositionOnWorld.Y;

				MessageDisplay.Add( "Vähä kyrsää... Brus suomalaista!" );
				MessageDisplay.MaxMessageCount = 0;
				k++;
			}




		}
	}


}