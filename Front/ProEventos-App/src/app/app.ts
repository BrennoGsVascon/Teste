import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Eventos } from "./eventos/eventos";
import { Palestrantes } from "./palestrantes/palestrantes";
import { NavComponent } from "./nav/Nav.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Eventos, Palestrantes, NavComponent],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('ProEventos-App');
}


