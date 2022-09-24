import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatSliderModule } from '@angular/material/slider';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatIconModule} from '@angular/material/icon';
import {MatCheckboxModule} from '@angular/material/checkbox';



import { HeaderComponent } from './components/header/header.component';
import { ToDoListComponent } from './components/to-do-list/to-do-list.component';
import { AllCheckComponent } from './components/all-check/all-check.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ToDoListComponent,
    AllCheckComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatExpansionModule,
    MatFormFieldModule,
    MatIconModule,
    MatCheckboxModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
