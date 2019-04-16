import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { CardDeck } from './card/shared/card.model';
import { Card } from './card/shared/card.model';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  private readonly HS_API_URL = 'https://omgvamp-hearthstone-v1.p.rapidapi.com';
  private readonly API_KEY = '260f59f627mshcca5c4736769af1p161fb9jsndec830d39cca';

  headers = new HttpHeaders({'X-Mashape-Key' : this.API_KEY});
  constructor(private http: HttpClient) { 
    
  }

  public getAllCardDecks():Observable<CardDeck[]>{
    return this.http.get<CardDeck[]>(this.HS_API_URL+'/info',{headers: this.headers});
  }

  public getCardByDeck(cardDeckGroup: string, cardDeck: string): Observable<Card[]>{
    return this.http.get<Card[]>(this.HS_API_URL + '/cards/' + cardDeckGroup + '/' + cardDeck, {headers:this.headers})
  }
}
