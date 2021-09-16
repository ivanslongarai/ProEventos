import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Events',
  templateUrl: './Events.component.html',
  styleUrls: ['./Events.component.scss'],
})
export class EventsComponent implements OnInit {
  events: any = [];
  filteredEvents: any = [];
  imageWidth = 80;
  imageMargin = 2;
  private _listFilter = '';
  private _showImage = true;

  constructor(private http: HttpClient) {}

  public get listFilter(): string {
    return this._listFilter;
  }

  public set listFilter(value: string) {
    this._listFilter = value;
    this.filteredEvents = this.listFilter
      ? this.filterEvents(this.listFilter)
      : this.events;
  }

  filterEvents(listFilter: string): any {
    listFilter = listFilter.toLowerCase();
    return this.events.filter(
      (event: any) =>
        event.subject.toLocaleLowerCase().indexOf(listFilter) !== -1 ||
        event.local.toLocaleLowerCase().indexOf(listFilter) !== -1
    );
  }

  ngOnInit() {
    this.getEvents();
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/events').subscribe(
      (response) => {
        this.events = response;
        this.filteredEvents = response;
      },
      (error) => console.log(error)
    );
  }

  public setImageVisibility(): void {
    this._showImage = !this._showImage;
  }

  public getImageVisibility(): boolean {
    return this._showImage;
  }
}
