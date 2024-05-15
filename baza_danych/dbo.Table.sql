CREATE TABLE [dbo].[Table] (
    [Id]                         INT        IDENTITY (1,1) NOT NULL,
    [Poznan_dnia]                NCHAR (10) NULL,
    [numer_albumu]               NCHAR (10) NULL,
    [nazwisko_imie]              NCHAR (10) NULL,
    [semestr_rok]                NCHAR (10) NULL,
    [kierunek_i_stopien_studiow] NCHAR (10) NULL,
    [przedmiot]                  NCHAR (10) NULL,
    [punkty]                     NCHAR (10) NULL,
    [prowadzący]                 NCHAR (10) NULL,
    [uzasadnienie_wniosku]       NCHAR (10) NULL,
    [osoba_z_komisji_1]          NCHAR (10) NULL,
    [osoba_z_komisji_2]          NCHAR (10) NULL,
    [osoba_z_komisji_3]          NCHAR (10) NULL,
    [Poznan_dnia2]               NCHAR (10) NULL,
    [data_podpis_studenta]       NCHAR (10) NULL,
    [podpis]                     NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);