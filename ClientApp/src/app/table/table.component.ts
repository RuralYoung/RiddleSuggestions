import { Component } from '@angular/core';

import { RiddleSuggestion } from 'src/models/RiddleSuggestion.Model';
import { Repository } from 'src/models/Repository.Model';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {
  constructor( private _repository: Repository ) { }

  getRiddleSuggestion( id: number ): RiddleSuggestion | undefined {
    return this._repository.getRiddleSuggestion( id );
  }

  getRiddleSuggestions(): RiddleSuggestion[] {
    return this._repository.getRiddleSuggestions();
  }

  createRiddleSuggestion( riddleSuggestion: RiddleSuggestion ) {
    this._repository.createRiddleSuggestion( riddleSuggestion );
  }

  editRiddleSuggestion( riddleSuggestion: RiddleSuggestion ) {
    this._repository.updateRiddleSuggestion( riddleSuggestion );
  }

  deleteRiddleSuggestion( id: number ) {
    if (id != undefined )
      this._repository.deleteRiddleSuggestion( id );
  }
}
