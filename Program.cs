// See https://aka.ms/new-console-template for more information
using dm_cinema;

Cinema monCinema = Cinema.getInstance();
monCinema.setActeur(1, "Ford", "Harrison");
monCinema.setActeur(2, "Hanks", "Tom");

monCinema.setFilm(1982, "Sience-Ficton", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner", null);
monCinema.setFilm(1992, "Annimation",2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.","Toy Story", null);

