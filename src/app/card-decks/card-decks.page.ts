import { CardService } from './../card.service';
import { Component, OnInit } from '@angular/core';
import { CardDeck } from '../card/shared/card.model';


@Component({
  selector: 'app-card-decks',
  templateUrl: './card-decks.page.html',
  styleUrls: ['./card-decks.page.scss'],
})
export class CardDecksPage {

  readonly ALLOWED_DECKS:string[]=['classes', 'factions', 'qualities', 'types', 'races'];
  public cardDecks:CardDeck[] = [];

  constructor(private cardservice: CardService) { 
    this.getCardDecks();
  }

  extractAllowedDecks(cardDecks: CardDeck[]){
    this.ALLOWED_DECKS.forEach((deckName:string) => {
      this.cardDecks.push({name:deckName, types:cardDecks[deckName]})
    })
  }

  private getCardDecks(){
    this.cardservice.getAllCardDecks().subscribe(
      (cardDecksService: CardDeck[]) => {
        this.extractAllowedDecks(cardDecksService);
      }
    )
  }


}
