﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpihinArtur
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, p1, p2, p3, p4, p5, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14;
            Grid abs = new Grid();

            for (int i = 0; i < 10; i++)

            {

                abs.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            }


            for (int i = 0; i < 5; i++)

            {

                abs.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            }


            a1 = new Label { BackgroundColor = Color.White };

            abs.Children.Add(a1, 0, 0);

            Grid.SetColumnSpan(a1, 2);

            a2 = new Label { BackgroundColor = Color.White, Text = "1" };

            abs.Children.Add(a2, 3, 0);

            a3 = new Label { BackgroundColor = Color.White, Text = "2" };

            abs.Children.Add(a3, 4, 0);

            a4 = new Label { BackgroundColor = Color.White, Text = "3" };

            abs.Children.Add(a4, 5, 0);

            a5 = new Label { BackgroundColor = Color.White, Text = "4" };

            abs.Children.Add(a5, 6, 0);

            a6 = new Label { BackgroundColor = Color.White, Text = "5" };

            abs.Children.Add(a6, 7, 0);

            a7 = new Label { BackgroundColor = Color.White, Text = "6" };

            abs.Children.Add(a7, 8, 0);

            a8 = new Label { BackgroundColor = Color.White, Text = "7" };

            abs.Children.Add(a8, 9, 0);

            a9 = new Label { BackgroundColor = Color.White, Text = "8" };

            abs.Children.Add(a9, 10, 0);

            a10 = new Label { BackgroundColor = Color.White, Text = "9" };

            abs.Children.Add(a10, 11, 0);


            p1 = new Label { BackgroundColor = Color.White, Text = "Понедельник" };

            abs.Children.Add(p1, 0, 1);

            Grid.SetColumnSpan(p1, 2);

            p2 = new Label { BackgroundColor = Color.White, Text = "Вторник" };

            abs.Children.Add(p2, 0, 2);

            Grid.SetColumnSpan(p2, 2);

            p3 = new Label { BackgroundColor = Color.White, Text = "Среда" };

            abs.Children.Add(p3, 0, 3);

            Grid.SetColumnSpan(p3, 2);

            p4 = new Label { BackgroundColor = Color.White, Text = "Четверг" };

            abs.Children.Add(p4, 0, 4);

            Grid.SetColumnSpan(p4, 2);

            p5 = new Label { BackgroundColor = Color.White, Text = "Пятница" };

            abs.Children.Add(p5, 0, 5);

            Grid.SetColumnSpan(p5, 2);


            r1 = new Label { BackgroundColor = Color.Yellow, Text = "Keel ja \n Kirjandus" };

            abs.Children.Add(r1, 3, 1);

            Grid.SetColumnSpan(r1, 2);


            r2 = new Label { BackgroundColor = Color.Purple, Text = "Võrgud ja Seadm." };

            abs.Children.Add(r2, 5, 1);

            Grid.SetColumnSpan(r2, 3);


            r3 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };

            abs.Children.Add(r3, 8, 1);

            Grid.SetColumnSpan(r3, 3);


            r4 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };

            abs.Children.Add(r4, 3, 2);

            Grid.SetColumnSpan(r4, 3);


            r5 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };

            abs.Children.Add(r5, 7, 2);

            Grid.SetColumnSpan(r5, 2);


            r6 = new Label { BackgroundColor = Color.DeepPink, Text = "Eesti keel \n teise kellena" };

            abs.Children.Add(r6, 9, 2);

            Grid.SetColumnSpan(r6, 2);


            r7 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };

            abs.Children.Add(r7, 3, 3);

            Grid.SetColumnSpan(r7, 3);


            r8 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };

            abs.Children.Add(r8, 6, 3);

            Grid.SetColumnSpan(r8, 5);


            r9 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };

            abs.Children.Add(r9, 11, 3);


            r10 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };

            abs.Children.Add(r10, 3, 4);

            Grid.SetColumnSpan(r10, 3);


            r11 = new Label { BackgroundColor = Color.Gray, Text = "Võrgud ja Seadm." };

            abs.Children.Add(r11, 7, 4);

            Grid.SetColumnSpan(r11, 2);


            r12 = new Label { BackgroundColor = Color.DeepPink, Text = "Inglise W.hald" };

            abs.Children.Add(r12, 9, 4);

            Grid.SetColumnSpan(r12, 2);


            r13 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };

            abs.Children.Add(r13, 3, 5);


            r14 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };

            abs.Children.Add(r14, 5, 5);

            Grid.SetColumnSpan(r14, 3);

            Content = abs;
        }
    }
}
