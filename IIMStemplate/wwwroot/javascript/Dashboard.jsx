class Dashboard extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // possibly cache information from below into state object for faster rendering if revisiting page - cutdown calls to backend
    }                   // based on your policy add the level of access to state use this to render different navbar based on level
    render() {
        return (
            <div className="Dashboard">I am a Dashboard landing page.
            </div>
            // Recent actions - Source is logs - fetch 3 - 5 most recent actions display in a list 
            // ?Receent or Pending orders - Source is Orders - top 3 - 5 orders depends on use case
            // Misc - admin shows pending user approvals - top 3 - 5 oldest --- Hidden for normal users 
        );
    }
}

export Dashboard;