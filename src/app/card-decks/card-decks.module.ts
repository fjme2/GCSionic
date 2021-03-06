import { CardDeck } from './../card/shared/card.model';
import { CardListComponent } from './../components/card-list/card-list.component';
import { CardService } from './../card.service';
import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { CardDecksPage } from './card-decks.page';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = [
  {
    path: '',
    component: CardDecksPage 
  },
  {
    path: 'card-listing/:cardDeckGroup/:cardDeck',
    loadChildren: '../card-listing/card-listing.module#CardListingPageModule'
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes),
    HttpClientModule
  ],
  providers: [CardService],
  declarations: [CardDecksPage, CardListComponent]
})
export class CardDecksPageModule {}
