import { Component } from '@angular/core';

import { RiddleSuggestion } from 'src/models/RiddleSuggestion.Model';
import { RiddleSuggestionsService } from 'src/services/riddle-suggestions.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {
  constructor( private _riddleSuggestionService: RiddleSuggestionsService ) {
    
  }

  
}
