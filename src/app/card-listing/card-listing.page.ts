import { CardService } from './../card.service';
import { Component } from '@angular/core';
import { ActivatedRoute } from'@angular/router';
import { Card } from './../card/shared/card.model';

@Component({
  selector: 'app-card-listing',
  templateUrl: './card-listing.page.html',
  styleUrls: ['./card-listing.page.scss'],
})
export class CardListingPage {

  CardDeckGroup: string;
  CardDeck: string;
  cards: Card[] = [];

  constructor(private route: ActivatedRoute, private cardService: CardService) { }

  ionViewWillEnter(){
   
    this.CardDeck = this.route.snapshot.paramMap.get('cardDeck');
    this.CardDeckGroup = this.route.snapshot.paramMap.get('cardDeckGroup');

    this.cardService.getCardByDeck(this.CardDeckGroup, this.CardDeck).subscribe(
      (cards:Card[]) => {
        this.cards = cards;
      }
    );

  }

}
