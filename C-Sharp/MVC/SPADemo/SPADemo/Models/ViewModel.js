
var AppViewModel = function () {
    var self = this;
    self.random = ko.observable("");
    self.noun = ko.observable("");
    self.verb = ko.observable("");
    self.adjective = ko.observable("");
    self.name = ko.observable("");    
    self.clicked = ko.observable(false);

    self.showLib = function () {
        self.clicked(!self.clicked());
    };
}
ko.applyBindings(new AppViewModel());