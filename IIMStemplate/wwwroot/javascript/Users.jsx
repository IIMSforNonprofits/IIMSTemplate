class Users extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated users list. Proof of life is full list. 
    // =======================================

    render() {
        return (
            <div className="Users">I am a User approval dashboard page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}

export Users;