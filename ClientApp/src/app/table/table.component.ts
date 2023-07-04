import { Component, OnInit } from '@angular/core';

import { RiddleSuggestion } from 'src/models/RiddleSuggestion.Model';
import { RiddleSuggestionsService } from 'src/services/riddle-suggestions.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {
  protected riddleSuggestions: RiddleSuggestion[] = [];
  
  constructor( private _riddleSuggestionsService: RiddleSuggestionsService ) {}

  ngOnInit(): void {
    this.getRiddleSuggestions();
  }

  getRiddleSuggestions(): void {
    this._riddleSuggestionsService.getRiddleSuggestions()
      .subscribe( serverRiddleSuggestions => this.riddleSuggestions = serverRiddleSuggestions );
  }

  /*getRiddleSuggestion(id: number): void {
    this._riddleSuggestionsService.getRiddleSuggestion(id)
      .subscribe( serverRiddleSuggestion => this.riddleSuggestions[id] = serverRiddleSuggestion );
  }*/

  saveRiddleSuggestion(riddleSuggestion: RiddleSuggestion): void {
    if (riddleSuggestion.riddleId == null ) {
      this._riddleSuggestionsService.postRiddleSuggestion(riddleSuggestion)
        .subscribe( serverRiddleSuggestion => this.riddleSuggestions.push(serverRiddleSuggestion) );
    }
    else {
      this._riddleSuggestionsService.putRiddleSuggestion(riddleSuggestion)
        .subscribe( serverRiddleSuggestion => {
          let i = this.riddleSuggestions.findIndex( ( j: RiddleSuggestion ) => j.riddleId == serverRiddleSuggestion.riddleId );
          this.riddleSuggestions.splice( i, 1, serverRiddleSuggestion);
        } );
    }
  }

  deleteRiddleSuggestion(id: number): void {
    this._riddleSuggestionsService.deleteRiddleSuggestion(id)
      .subscribe( () => {
        let i = this.riddleSuggestions.findIndex( ( j: RiddleSuggestion ) => j.riddleId == id );
        if ( -1 < i )
          this.riddleSuggestions.splice( i, 1 );
      } );
  }
}
