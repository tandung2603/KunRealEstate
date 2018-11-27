import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PropertyList } from './property/propertyList.component';
import { SearchComponent } from './property/search.component';
import { PropertyPaging } from './property/propertyPaging.component';
import { DataService } from './share/dataService'

@NgModule({
    declarations: [
        AppComponent,
        PropertyList,
        SearchComponent,
        PropertyPaging
    ],
    imports: [
        BrowserModule,
        HttpClientModule
    ],
    providers: [
        DataService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
