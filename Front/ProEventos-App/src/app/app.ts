import { Component, signal } from '@angular/core';
import { EventosComponent } from './eventos/eventos';
import { Palestrantes } from './palestrantes/palestrantes';
import { NavComponent } from './nav/Nav.component';
import { CollapseModule} from 'ngx-bootstrap/collapse';
import { FormsModule } from '@angular/forms';

const appMeta = {
  selector: 'app-root',
  standalone: true,
  imports: [EventosComponent, Palestrantes, NavComponent, CollapseModule, FormsModule],
  templateUrl: './app.html',
  styleUrls: ['./app.scss']
};

class AppClass {
  protected readonly title = signal('ProEventos-App');
}

export const App = Component(appMeta)(AppClass);


